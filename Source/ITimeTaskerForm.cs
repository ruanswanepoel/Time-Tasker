
using System.Collections.ObjectModel;


namespace TimeTasker {

	public interface ITimeTaskerForm {

		ObservableCollection<TaskControl> Tasks { get; }

	}

}
