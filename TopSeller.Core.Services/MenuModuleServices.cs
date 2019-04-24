/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 14:20:18
*生成者：xiongyuwen
*/
using TopSeller.Core.Services.Base;
using TopSeller.Core.Entity.Models;
using TopSeller.Core.IRepository;
using TopSeller.Core.IServices;

namespace TopSeller.Core.Services
{
    public class MenuModuleServices : BaseServices<MenuModule>, IMenuModuleServices
    {
        IMenuModuleRepository _dal;
        public MenuModuleServices(IMenuModuleRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}