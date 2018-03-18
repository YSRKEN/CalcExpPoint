using Reactive.Bindings;
using System;
using System.ComponentModel;

namespace CalcExpPoint
{
	class MainViewModel : INotifyPropertyChanged
	{
		public ReactiveProperty<int> NowLevel { get; } = new ReactiveProperty<int>(1);
		public ReactiveProperty<int> EndLevel { get; } = new ReactiveProperty<int>(165);
		public ReactiveProperty<string> OutputMessage { get; } = new ReactiveProperty<string>("");
		public ReactiveCommand CalcCommand { get; } = new ReactiveCommand();
		//
		public MainViewModel()
		{
			CalcCommand.Subscribe(_ => {
				OutputMessage.Value = "テスト";
			});
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
