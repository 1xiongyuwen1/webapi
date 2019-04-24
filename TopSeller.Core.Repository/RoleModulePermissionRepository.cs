/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 14:03:10
*生成者：xiongyuwen
*/
using TopSeller.Core.Repository.Base;
using TopSeller.Core.Entity.Models;
using TopSeller.Core.IRepository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TopSeller.Core.Repository
{
    public class RoleModulePermissionRepository : BaseRepository<RoleModulePermission>, IRoleModulePermissionRepository
    {
        public async Task<List<RoleModulePermission>> WithChildrenModel()
        {
            var list = await Task.Run(() => Db.Queryable<RoleModulePermission>()
                    .Mapper(it => it.Role, it => it.RoleId)
                    .Mapper(it => it.Permission, it => it.PermissionId)
                    .Mapper(it => it.Module, it => it.ModuleId).ToList());

            return null;
        }
    }
}