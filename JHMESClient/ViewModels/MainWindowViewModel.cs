using JHMESClient.Models;
using JHMESClient.Models.Enum;
using Prism.Commands;
using Prism.Mvvm;
using System;
using Unity;

namespace JHMESClient.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "测试表头";
        [Dependency]
        public JHDBContext JHDBContext { get; set; }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand AddRole { get; private set; }
        public MainWindowViewModel()
        {
            AddRole = new DelegateCommand(AddRole_Click);
        }

        private void AddRole_Click()
        {
            Role role = new Role();
            role.Remark = string.Empty;
            role.RoleDescription = string.Empty;
            role.RoleName = "角色1";
            role.DataStatus = DataStatus.Add;
            role.IsDistribution = true;
            JHDBContext.Add(role);
            JHDBContext.SaveChanges();
        }
    }
}
