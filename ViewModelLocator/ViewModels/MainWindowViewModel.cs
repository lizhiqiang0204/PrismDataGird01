using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace ViewModelLocator.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region  公有成员
        private ObservableCollection<ListModel> peopleList = new ObservableCollection<ListModel>();
        public ObservableCollection<ListModel> PeopleList
        {
            get { return peopleList; }
            set { peopleList = value;}
        }

        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region 构造方法
        public MainWindowViewModel()
        {
            PeopleList.Add(new ListModel{ Name = "小明",Age = 15});//添加行信息
            PeopleList.Add(new ListModel{ Name = "小王",Age = 14});
            peopleList.Add(new ListModel { Name = "小李", Age = 13 });
        }
        #endregion
    }
    #region 自定义类
    public class ListModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    #endregion
}
