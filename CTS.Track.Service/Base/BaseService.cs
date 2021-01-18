using CTS.Track.Common.Helper;
using CTS.Track.IRepository.Base;
using CTS.Track.IService.Base;
using CTS.Track.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CTS.Track.Service.Base
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        private readonly IBaseRepository<TEntity> baseDal;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            baseDal = baseRepository;

        }


        /// <summary>
        /// 写入实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual async Task<bool> Add(TEntity model)
        {
            return await baseDal.Add(model);
        }

        /// <summary>
        /// 批量写入实体
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public virtual async Task<bool> Add(List<TEntity> models)
        {
            return await baseDal.Add(models);
        }

        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<bool> DeleteById(object id)
        {
            return await baseDal.DeleteById(id);
        }

        /// <summary>
        /// 根据ID数组删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>

        public virtual async Task<int> DeleteByIds(object[] ids)
        {
            return await baseDal.DeleteByIds(ids);
        }

        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="objId"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> GetById(object objId)
        {
            return await baseDal.GetById(objId);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public virtual async Task<Tuple<List<TEntity>, int, int>> PageList(int pageIndex, int pageSize)
        {
            return await baseDal.PageList(pageIndex, pageSize);
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual async Task<bool> Update(TEntity model)
        {
            return await baseDal.Update(model);
        }


    }
}
