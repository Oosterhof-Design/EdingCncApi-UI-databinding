using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace OosterhofDesign.NotifyPropertyChanged
{


    /// <summary>
    /// Checks for changed properties from the CncServer
    /// </summary>
    /// <typeparam name="T">The CncApi type</typeparam>
    public class NotifyCncApiPropertyChanged<T> : INotifyPropertyChanged
    {
        private const string CodeWrapperNameSpace = "OosterhofDesign";
        private delegate void OnPropertyChangedMethod(string PROPERTY_NAME);
        private OnPropertyChangedMethod PropertyChangedMethod = null; 
        private PropertyInfo[] AllProperties = null;
        private object[] PropertiesCache = null;
        private T EventHandlerClass = default(T);
        private MethodInfo CncServerMethod = null;
        private object[] CncServerArgs = null;

        private object _MethodReturnValue = null;
        /// <summary>
        /// The return value from CncServerMethod. Only valid if you have set the CncServermethod in the contructor
        /// </summary>
        public object MethodReturnValue
        {
            get
            {
                return _MethodReturnValue;
            }
            set
            {
                if (value != null && value != _MethodReturnValue)
                {
                    _MethodReturnValue = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MethodReturnValue)));
                }
            }
        }
        /// <summary>
        /// The method that will handle the PropertyChangedEventHandler event
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method to raise the PropertyChangedEventHandler for the CncApi properties
        /// </summary>
        /// <param name="EVENT_HANDLER_CLASS">The object whose properties are to be checked</param>
        /// <param name="CNCSERVER_METHOD">Some CncServer methods are not returning pointers. Every time that you check the properties this method will also run. Note: Only needed if the method from the cncserver does not return a pointer.</param>
        /// <param name="CNCSERVER_METHOD_ARGS">Arguments for the CncServer Methods</param>
        /// <param name="CNCSERVER_OBJ">Object where the CncMethod is located. If the method is static this value can be null.</param>
        /// <param name="SELECTED_PROPERIES">Properties to check</param>

        public NotifyCncApiPropertyChanged(T EVENT_HANDLER_CLASS, MethodInfo CNCSERVER_METHOD = null, object[] CNCSERVER_METHOD_ARGS = null,object CNCSERVER_OBJ = null, PropertyInfo[] SELECTED_PROPERIES = null)
        {
            EventHandlerClass = EVENT_HANDLER_CLASS;
            Type ClassType = EventHandlerClass.GetType();
            CncServerMethod = CNCSERVER_METHOD;
            CncServerArgs = CNCSERVER_METHOD_ARGS;

            if (SELECTED_PROPERIES != null && SELECTED_PROPERIES.Length > 0)
            {
                AllProperties = SELECTED_PROPERIES;
            }
            else
            {
                //skip all properties where the property has namespace from the cncapi codewrapper and if its not an enum. The reason is that these properties will never change in the wrapper. You can bypass this restriction by setting in the contructor the propertyinfo.
                AllProperties = ClassType.GetProperties().Where((Class) =>
                {
                    bool Return = false;
                    Type TypeOfProperty = Class.PropertyType;

                    if (TypeOfProperty.IsArray == true)
                    {
                        Type ElementType = TypeOfProperty.GetElementType();

                        if (ElementType.Namespace != CodeWrapperNameSpace || ElementType.IsEnum == true)
                        {
                            Return = true;
                        }
                    }
                    else if (TypeOfProperty.Namespace != CodeWrapperNameSpace || TypeOfProperty.IsEnum == true)
                    {
                        Return = true;
                    }
                    return Return;
                }).ToArray();
            }
            PropertiesCache = new object[AllProperties.Length];
            PropertyChangedMethod = (OnPropertyChangedMethod)ClassType.GetMethod("OnPropertyChanged").CreateDelegate(typeof(OnPropertyChangedMethod), EventHandlerClass);
        }

        /// <summary>
        /// Method for comparing arrays (not implemented)
        /// </summary>
        /// <param name="VALUE_TYPE">Type of the value</param>
        /// <param name="CURRENT_VALUE">Current value from the CncServer</param>
        /// <param name="LAST_VALUE">previous value of the property</param>
        /// <param name="INFO">Property to check</param>
        /// <param name="CACHE_STORE">Location to save the current value for the next time to compare</param>
        /// <returns>if array is equal then it returns true</returns>
        public virtual bool CompareArray(Type VALUE_TYPE, object CURRENT_VALUE, object LAST_VALUE, PropertyInfo INFO, ref object CACHE_STORE)
        {
            bool Return = true;
            if (VALUE_TYPE.IsArray == true)
            {
                
            }
            return Return;
        }
        /// <summary>
        /// Ckeck for changes for all selected properties.
        /// </summary>
        public void InvokeCncApiPropertyChanged()
        {
            lock (PropertiesCache)
            {
                if (CncServerMethod != null)
                {
                    MethodReturnValue = CncServerMethod.Invoke(null, CncServerArgs);

                }
                for (int i = 0; i < AllProperties.Length; i++)
                {
                    PropertyInfo SelectedProperty = AllProperties[i];
                    object CurrentValue = SelectedProperty.GetValue(EventHandlerClass, null);
                    Type CurrentValueType = CurrentValue.GetType();
                    object LastValue = PropertiesCache[i];

                    if (CurrentValue.Equals(LastValue) == false || CompareArray(CurrentValueType, CurrentValue, LastValue, SelectedProperty, ref PropertiesCache[i]) == false)
                    {
                        PropertiesCache[i] = CurrentValue;
                        PropertyChangedMethod(SelectedProperty.Name);
                    }
                }
            }
        }
        
    }
}
