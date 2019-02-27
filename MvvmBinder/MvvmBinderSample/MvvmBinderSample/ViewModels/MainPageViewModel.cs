using System;
using System.Timers;
using System.Threading.Tasks;

using MvvmBinder;

namespace MvvmBinderSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _time;

        public string Time
        {
            get => _time;
            set { _time = value; RaisePropertyChanged(() => Time); }
        }

        Timer timer;

        public MainPageViewModel()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second  
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private async void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            await Task.Run(() => { Time = DateTime.Now.ToLongTimeString(); });
        }
    }
}
