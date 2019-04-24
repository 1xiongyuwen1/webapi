/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 13:37:55
*生成者：xiongyuwen
*/
using TopSeller.Core.IRepository.Base;
using TopSeller.Core.Entity.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TopSeller.Core.IRepository
{
    public interface IRoleModulePermissionRepository : IBaseRepository<RoleModulePermission>
    {
        Task<List<RoleModulePermission>> WithChildrenModel();
    }
}