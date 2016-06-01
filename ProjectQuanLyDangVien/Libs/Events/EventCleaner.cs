using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanLyDangVien.Libs.Events
{
   public static class EventCleaner
    {
        public static void ClearEventInvocations(this object obj, string eventName)
        {
            var fi = obj.GetType().GetEventField(eventName);
            obj.GetType().RemoveClickEvent(eventName, obj);
            if (fi == null) return;
            fi.SetValue(obj, null);
        }
        private static void RemoveClickEvent(this Type type,string eventName,object b)
        {
            BindingFlags myBindingFlags = BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;
            PropertyInfo proIfo = type.GetProperty("Events", myBindingFlags);
            EventHandlerList eventHandlerList = proIfo.GetValue(b, new object[] { }) as EventHandlerList;
            FieldInfo fieldInfo = type.GetField("Event" + eventName, myBindingFlags);
            if(fieldInfo != null)
            {
                object eventKey = fieldInfo.GetValue(b);
                var eventHandler = eventHandlerList[eventKey] as Delegate;
                Delegate[] invocationList = eventHandler.GetInvocationList();
                foreach (EventHandler item in invocationList)
                {
                    type.GetEvent(eventName).RemoveEventHandler(b, item);
                }
            }
            //FieldInfo f1 = type.GetField(eventName,
            //    BindingFlags.Static | BindingFlags.NonPublic);
            //object obj = f1.GetValue(b);
            //PropertyInfo pi = type.GetProperty("Events",
            //    BindingFlags.NonPublic | BindingFlags.Instance);
            //EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            //list.RemoveHandler(obj, list[obj]);
        }
        private static FieldInfo GetEventField(this Type type, string eventName)
        {
            FieldInfo field = null;
            BindingFlags myBindingFlags = BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;
            while (type != null)
            {
                /* Find events defined as field */
                var a = type.GetFields(myBindingFlags);
                field = type.GetField(eventName, myBindingFlags);
                if (field != null && (field.FieldType == typeof(MulticastDelegate) || field.FieldType.IsSubclassOf(typeof(MulticastDelegate))))
                    break;

                /* Find events defined as property { add; remove; } */
                field = type.GetField("EVENT_" + eventName.ToUpper(), myBindingFlags);
                if (field != null)
                    break;
                type = type.BaseType;
            }
            return field;
        }
    }
}
