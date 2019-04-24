/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 14:20:35
*生成者：xiongyuwen
*/
using TopSeller.Core.Services.Base;
using TopSeller.Core.Entity.Models;
using TopSeller.Core.IRepository;
using TopSeller.Core.IServices;

namespace TopSeller.Core.Services
{
    public class PermissionServices : BaseServices<Permission>, IPermissionServices
    {
        IPermissionRepository _dal;
        public PermissionServices(IPermissionRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}