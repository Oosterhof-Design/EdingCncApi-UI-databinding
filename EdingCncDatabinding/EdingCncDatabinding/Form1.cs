using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OosterhofDesign;
using OosterhofDesign.NotifyPropertyChanged;
using System.Reflection;
using System.Threading;
namespace EdingCncDatabinding
{
    public partial class Form1 : Form
    {

        private bool BindingIsset = false;

        private CncCartDouble DataSource_WorkPostion = null;
        private CncJointCfg[] DataSource_JointConfig = null;
        private NotifyCncApiPropertyChanged<CncCartDouble> NotifyPropertyChanged_WorkPosition = null;
        private NotifyCncApiPropertyChanged<CncJointCfg>[] NotifyPropertyChanged_JointConfig = null;
        private CancellationTokenSource CancelToken = null;

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += MyClosedHandler;


        }
        ~Form1()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void  ConnectCncServer_Click(object sender, EventArgs e)
        {
            Cnc_Rc Rc = G_GetCncServer.ConnectServer("");
            if (Rc == Cnc_Rc.CNC_RC_OK || Rc == Cnc_Rc.CNC_RC_ALREADY_RUNS || Rc == Cnc_Rc.CNC_RC_ALREADY_CONNECTED)
            {
                if (BindingIsset == false)
                {
                    BindingIsset = true;

                    //Configuration for workposition:
                    DataSource_WorkPostion = G_StatusItemsposition.GetWorkPosition();
                    MethodInfo Method_GetWorkPosition = typeof(G_StatusItemsposition).GetMethod(nameof(G_StatusItemsposition.GetWorkPosition));//method to invoke every time when check on value changes
                    NotifyPropertyChanged_WorkPosition = new NotifyCncApiPropertyChanged<CncCartDouble>(DataSource_WorkPostion, Method_GetWorkPosition);//extra method is required because G_StatusItemsposition.GetWorkPosition(); contains not a pointer to the CncServer
                    CancelToken = new CancellationTokenSource();


                    AxisX.DataBindings.Add(nameof(TextBox.Text), DataSource_WorkPostion, nameof(CncCartDouble.x));
                    AxisY.DataBindings.Add(nameof(TextBox.Text), DataSource_WorkPostion, nameof(CncCartDouble.y), true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.00");
                    AxisZ.DataBindings.Add(nameof(TextBox.Text), DataSource_WorkPostion, nameof(CncCartDouble.z), true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.000");




                    //Configuration items JointConfig
                    DataSource_JointConfig = G_GetConfigItems.GetAllJointConfig();
                    NotifyPropertyChanged_JointConfig = new NotifyCncApiPropertyChanged<CncJointCfg>[DataSource_JointConfig.Length];
                    for (int i = 0; i < DataSource_JointConfig.Length; i++)
                    {
                        NotifyPropertyChanged_JointConfig[i] = new NotifyCncApiPropertyChanged<CncJointCfg>(DataSource_JointConfig[i]);//Note: no methodinfo parameter used. G_GetConfigItems.GetAllJointConfig(); method contains a pointer to the CncServer. this is not the case by G_StatusItemsposition.GetWorkPosition();
                    }
                    PosLimit_X.DataBindings.Add(nameof(TextBox.Text), DataSource_JointConfig[0], nameof(CncJointCfg.positiveLimit), false, DataSourceUpdateMode.OnPropertyChanged);
                    PosLimit_Y.DataBindings.Add(nameof(TextBox.Text), DataSource_JointConfig[1], nameof(CncJointCfg.positiveLimit), false, DataSourceUpdateMode.OnPropertyChanged);
                    PosLimit_Z.DataBindings.Add(nameof(TextBox.Text), DataSource_JointConfig[2], nameof(CncJointCfg.positiveLimit), false, DataSourceUpdateMode.OnPropertyChanged);

                    //Check the CncServer values. Interval time can be changed in the UI
                    CncServerVars();
                }

                MessageBox.Show("CncRc State:" + Rc.ToString(), "CncServer is connected ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("CncRc State:" + Rc.ToString(), "CncServer ConnectServer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                G_GetCncServer.DisConnectServer();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected void MyClosedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("exit");
            if (CancelToken != null)
            {
                CancelToken.Cancel();
            }
            OosterhofDesign.G_GetCncServer.DisConnectServer();
        }
        private async void CncServerVars()
        {
           
            while (true)
            {
                Console.WriteLine(".");
                try
                {
                    NotifyPropertyChanged_WorkPosition.InvokeCncApiPropertyChanged();
                    for (int i = 0; i < NotifyPropertyChanged_JointConfig.Length; i++)
                    {
                        NotifyPropertyChanged_JointConfig[i].InvokeCncApiPropertyChanged();
                    }
                    await Task.Delay(IntervalTask.Value);
                    if (CancelToken.IsCancellationRequested == true)
                    {
                      
                        break;
                    }
                }
                catch (Exception f)
                {
                    Console.WriteLine(f);
                }
            }
           
        }
        private async void SystemConfig_Click(object sender, EventArgs e)
        {
            SystemConfig.Enabled = false;
            Task<Cnc_Rc> LongTask = Task.Run(()=>
            {
                return G_GetConfigItems.StoreIniFile(true);
            });
            await LongTask;
            SystemConfig.Enabled = true;

        }

        private void IntervalTask_Scroll(object sender, EventArgs e)
        {
           
        }
    }
}
