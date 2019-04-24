/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 14:20:56
*生成者：xiongyuwen
*/
using TopSeller.Core.Services.Base;
using TopSeller.Core.Entity.Models;
using TopSeller.Core.IRepository;
using TopSeller.Core.IServices;

namespace TopSeller.Core.Services
{
    public class RoleServices : BaseServices<Role>, IRoleServices
    {
        IRoleRepository _dal;
        public RoleServices(IRoleRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
    }
}