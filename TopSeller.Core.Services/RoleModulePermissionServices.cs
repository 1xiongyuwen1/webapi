/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 14:21:21
*生成者：xiongyuwen
*/
using TopSeller.Core.Services.Base;
using TopSeller.Core.Entity.Models;
using TopSeller.Core.IRepository;
using TopSeller.Core.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopSeller.Core.Common;

namespace TopSeller.Core.Services
{
    public class RoleModulePermissionServices : BaseServices<RoleModulePermission>, IRoleModulePermissionServices
    {
        IRoleModulePermissionRepository _dal;
        readonly IMenuModuleRepository _moduleRepository;
        readonly IRoleRepository _roleRepository;
        public RoleModulePermissionServices(IRoleModulePermissionRepository dal, IMenuModuleRepository moduleRepository, IRoleRepository roleRepository)
        {
            this._dal = dal;
            base.BaseDal = dal;
            this._moduleRepository = moduleRepository;
            this._roleRepository = roleRepository;
        }

        /// <summary>
        /// 获取全部 角色接口(按钮)关系数据
        /// </summary>
        /// <returns></returns>
        [Caching(AbsoluteExpiration = 10)]
        public async Task<List<RoleModulePermission>> GetRoleModule()
        {
            var roleModulePermissions = await base.Query();
            if(roleModulePermissions.Count>0)
            {
                foreach (var item in roleModulePermissions)
                {
                    item.Role = await _roleRepository.QueryById(item.RoleId);
                    item.Module = await _moduleRepository.QueryById(item.ModuleId);
                }
            }
            return roleModulePermissions;
        }

        public async Task<List<RoleModulePermission>> TestModelWithChildren()
        {
            return await _dal.WithChildrenModel();
        }
    }
}