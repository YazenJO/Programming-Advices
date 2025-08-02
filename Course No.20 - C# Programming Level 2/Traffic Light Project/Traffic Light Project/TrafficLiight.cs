using System;
using System.Windows.Forms;

namespace Traffic_Light_Project
{
    public partial class TrafficLiight : UserControl
    {
        public enum LightEnum { Red = 0, Orange = 1, Green = 2 }
        private LightEnum _CurrentLight = LightEnum.Red;
        private int  _CountDownValue;
        public TrafficLiight()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

       
        
        
        private int _RedTime = 10;
        private int _OrangeTime = 3;
        private int _GreenTime = 10;
       
        

        public int RedTime
        {
            get
            { return _RedTime; }
            set
            { _RedTime = value; }
        }

        public int OrangeTime
        {
            get
            { return _OrangeTime; }
            set
            { _OrangeTime = value; }
        }

        public int GreenTime
        {
            get
            { return _GreenTime; }
            set
            {_GreenTime = value; }
        }  
       

        public class TraficLightEventArgs : EventArgs
        {
            public LightEnum CurrentLight { get; }
            public int LightDuration { get; }

            public TraficLightEventArgs(LightEnum light, int time)
            {
                CurrentLight = light;
                LightDuration = time;
            }
        }
        public event EventHandler <TraficLightEventArgs> RedLightOn;
        public void OnRedLightOn()
        {
            RedLightOn?.Invoke(this, new TraficLightEventArgs(LightEnum.Red,_RedTime));
        }
        public event EventHandler<TraficLightEventArgs> OrangeLightOn;
        public void OnOrangeLightOn()
        {
            OrangeLightOn?.Invoke(this, new TraficLightEventArgs(LightEnum.Orange, _OrangeTime));
        }
        public event EventHandler<TraficLightEventArgs> GreenLightOn;

        public void OnGreenLightOn()
        {
            GreenLightOn?.Invoke(this, new TraficLightEventArgs(LightEnum.Green, _GreenTime));
        }
        
       

        

        
        public int GetCurrentTime()
        {
            switch (_CurrentLight)
            {
                case LightEnum.Orange:
                    return OrangeTime;

                case LightEnum.Green:
                    return GreenTime;

                case LightEnum.Red:
                    return RedTime;

                default:
                    return RedTime;
            }
        }
        public void Start()
        {
            _CountDownValue = GetCurrentTime();
            LightTimer.Start();

        }


        private void LightTimer_Tick(object sender, EventArgs e)
        {
            LbTimer.Text = _CountDownValue.ToString();
            if (_CountDownValue == 0)
            {
                _ChangeLight();
            }
            else
            {
                --_CountDownValue;
            }
        }

        private void _ChangeLight()
        {
            switch (_CurrentLight)
            {
                case LightEnum.Red:
                    _CurrentLight = LightEnum.Orange;
                    PbTrafficLight.Image = Properties.Resources.Orange;
                    _CountDownValue = OrangeTime;
                    LbTimer.Text = _CountDownValue.ToString();
                    OnOrangeLightOn();
                    break;
                case LightEnum.Orange:
                    _CurrentLight = LightEnum.Green;
                    PbTrafficLight.Image = Properties.Resources.Green;
                    _CountDownValue = GreenTime;
                    LbTimer.Text = _CountDownValue.ToString();
                    OnGreenLightOn();
                    break;
                case LightEnum.Green:
                    _CurrentLight = LightEnum.Red;
                    PbTrafficLight.Image = Properties.Resources.Red;
                    _CountDownValue = RedTime;
                    LbTimer.Text = _CountDownValue.ToString();
                    OnRedLightOn();
                    break;
            }
        }
    }
}