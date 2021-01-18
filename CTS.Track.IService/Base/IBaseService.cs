using CTS.Track.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Track.IService.Base
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        /// <summary>
        /// 根据ID列表删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<int> DeleteByIds(object[] ids);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteById(object id);


        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="objId"></param>
        /// <returns></returns>
        Task<TEntity> GetById(object objId);

        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> Add(TEntity model);

        /// <summary>
        /// 批量添加实体
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        Task<bool> Add(List<TEntity> models);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        Task<bool> Update(TEntity model);


        /// <summary>
        /// 分页列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<Tuple<List<TEntity>, int, int>> PageList(int pageIndex, int pageSize);
    }
}
