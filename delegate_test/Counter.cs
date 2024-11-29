using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_test
{
    public class Counter
    {
        public int CurrentCount { get; set; } = 0;
        public int MaxCapacity { get; } = 5;
        //可以把这里做成自己的
        //public delegate void NumberChangedHandler(int currentCount);
        //可以定义一个事件参数类。
        //public class NumberChangedEventArgs : EventArgs
        //{
        //    public int CurrentCount { get; set; }
        //    public string Message { get; set; }
        //}
        //public delegate void NumberChangedHandler(object sender, NumberChangedEventArgs e);

        //public event NumberChangedHandler NumberExceed;
        //public event NumberChangedHandler NumberBelowed;
        //NumberExceed?.Invoke(this, new NumberChangedEventArgs { CurrentCount = CurrentCount, Message = "超出限制!" });
        //private void Counter_NumberExceed(object sender, NumberChangedEventArgs e)
        //{
        //    lblAlert.Text = $"警告: {e.Message} 当前人数: {e.CurrentCount}";
        //    lblAlert.ForeColor = System.Drawing.Color.Red;
        //}
    //总结
    //自定义事件提供了更大的灵活性，允许你定义适合业务需求的事件机制。
    //通过结合自定义委托和事件参数类型，可以支持更加复杂的事件数据传递。
    //整个架构依然遵循发布-订阅模式，确保松耦合和可扩展性。
        public event EventHandler<int> NumberExceed;
        public event EventHandler<int> NumberBelowed;

        // 添加人员
        public void AddPerson()
        {
            CurrentCount += 1;
            if (CurrentCount > MaxCapacity)
            {
                NumberExceed?.Invoke(this, CurrentCount);
            }
        }

        public void RemovePerson()
        {
            if (CurrentCount > 0)
            {
                CurrentCount--;
                if(CurrentCount <= MaxCapacity)
                {
                    NumberBelowed?.Invoke(this, CurrentCount);
                }
            }
        }

    }
}
