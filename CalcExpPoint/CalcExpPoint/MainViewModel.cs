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
				if(NowLevel.Value <= 0 || NowLevel.Value > 165)
				{
					OutputMessage.Value = "エラー：現在のレベルは1以上165以下の整数で入力してください";
				}else if (EndLevel.Value <= 0 || EndLevel.Value > 165)
				{
					OutputMessage.Value = "エラー：目標のレベルは1以上165以下の整数で入力してください";
				}
				else {
					OutputMessage.Value = $"{Library.WantExpByLevelDifference(NowLevel.Value, EndLevel.Value)}";
				}
			});
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
