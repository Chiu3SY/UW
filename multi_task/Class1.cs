using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_task
{
    //object sender是必须的吗：不是，但是可以用来区分事件源，比如说有两个counter实例，用来区分是哪一个counter发起的事件
    delegate void DataCollectedEventHandler(object sender, event_parameter e);
    public class Class1
    {
        public Model data;

        //public event DataCollectedEventHandler dataCollected;
        public Class1()
        {
            Model data = new Model();
        }
        
        public void autocamparator()
        {
            if (data.collectedData > 90)
            {
                //dataCollected?.Invoke(this, new event_parameter { BackgroundColor = Color.White ,ForegroundColor=Color.Red});
            }
            else if(data.collectedData < 20) {
                //dataCollected?.Invoke(this, new event_parameter { BackgroundColor = Color.White, ForegroundColor = Color.Blue });
            }

        }
    }

}
