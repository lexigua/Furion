﻿using Fur.DatabaseVisitor.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading.Tasks;

namespace Fur.DatabaseVisitor.Repositories.Partials.Interfaces
{
    /// <summary>
    /// 泛型仓储 查找并删除操作 分部接口
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    public partial interface IRepositoryOfT<TEntity> where TEntity : class, IDbEntity, new()
    {
        #region 查找并真删除操作 + EntityEntry<TEntity> FindToDelete(object id)
        /// <summary>
        /// 查找并真删除操作
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="EntityEntry{TEntity}"/></returns>
        EntityEntry<TEntity> FindToDelete(object id);
        #endregion

        #region 查找并真删除操作 + Task<EntityEntry<TEntity>> FindToDeleteAsync(object id)
        /// <summary>
        /// 查找并真删除操作
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FindToDeleteAsync(object id);
        #endregion


        #region 查找并真删除操作（抛异常） + EntityEntry<TEntity> FindToDelete(object id, Exception notFoundException)
        /// <summary>
        /// 查找并真删除操作（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="notFoundException">未找到异常</param>
        /// <returns><see cref="EntityEntry{TEntity}"/></returns>
        EntityEntry<TEntity> FindToDelete(object id, Exception notFoundException);
        #endregion

        #region 查找并真删除操作（抛异常） + Task<EntityEntry<TEntity>> FindToDeleteAsync(object id, Exception notFoundException)
        /// <summary>
        /// 查找并真删除操作（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="notFoundException">未找到异常</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FindToDeleteAsync(object id, Exception notFoundException);
        #endregion


        #region 查找并真删除操作（抛异常） + EntityEntry<TEntity> FindToDelete(object id, int oopsCode)
        /// <summary>
        /// 查找并真删除操作（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="oopsCode">错误状态码</param>
        /// <returns><see cref="EntityEntry{TEntity}"/></returns>
        EntityEntry<TEntity> FindToDelete(object id, int oopsCode);
        #endregion

        #region 查找并真删除操作（抛异常） + EntityEntry<TEntity> FindToDelete(object id, string oopsCode)
        /// <summary>
        /// 查找并真删除操作（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="oopsCode">错误状态码</param>
        /// <returns><see cref="EntityEntry{TEntity}"/></returns>
        EntityEntry<TEntity> FindToDelete(object id, string oopsCode);
        #endregion

        #region 查找并真删除操作（抛异常） + Task<EntityEntry<TEntity>> FindToDeleteAsync(object id, int oopsCode)
        /// <summary>
        /// 查找并真删除操作（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="oopsCode">错误状态码</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FindToDeleteAsync(object id, int oopsCode);
        #endregion

        #region 查找并真删除操作（抛异常） + Task<EntityEntry<TEntity>> FindToDeleteAsync(object id, string oopsCode)
        /// <summary>
        /// 查找并真删除操作（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="oopsCode">错误状态码</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FindToDeleteAsync(object id, string oopsCode);
        #endregion


        #region 查找并真删除操作并立即保存 + EntityEntry<TEntity> FindToDeleteSaveChanges(object id)
        /// <summary>
        /// 查找并真删除操作并立即保存
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="EntityEntry{TEntity}"/></returns>
        EntityEntry<TEntity> FindToDeleteSaveChanges(object id);
        #endregion

        #region 查找并真删除操作并立即保存 + Task<EntityEntry<TEntity>> FindToDeleteSaveChangesAsync(object id)
        /// <summary>
        /// 查找并真删除操作并立即保存
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FindToDeleteSaveChangesAsync(object id);
        #endregion

        #region 查找并真删除操作并立即保存（抛异常） + EntityEntry<TEntity> FindToDeleteSaveChanges(object id, int oopsCode)
        /// <summary>
        /// 查找并真删除操作并立即保存（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="oopsCode">错误状态码</param>
        /// <returns><see cref="EntityEntry{TEntity}"/></returns>
        EntityEntry<TEntity> FindToDeleteSaveChanges(object id, int oopsCode);
        #endregion

        #region 查找并真删除操作并立即保存（抛异常） + EntityEntry<TEntity> FindToDeleteSaveChanges(object id, string oopsCode)
        /// <summary>
        /// 查找并真删除操作并立即保存（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="oopsCode">错误状态码</param>
        /// <returns><see cref="EntityEntry{TEntity}"/></returns>
        EntityEntry<TEntity> FindToDeleteSaveChanges(object id, string oopsCode);
        #endregion

        #region 查找并真删除操作并立即保存（抛异常）+ Task<EntityEntry<TEntity>> FindToDeleteSaveChangesAsync(object id, int oopsCode)
        /// <summary>
        /// 查找并真删除操作并立即保存（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="oopsCode">错误状态码</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FindToDeleteSaveChangesAsync(object id, int oopsCode);
        #endregion

        #region 查找并真删除操作并立即保存（抛异常） + Task<EntityEntry<TEntity>> FindToDeleteSaveChangesAsync(object id, string oopsCode)
        /// <summary>
        /// 查找并真删除操作并立即保存（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="oopsCode">错误状态码</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FindToDeleteSaveChangesAsync(object id, string oopsCode);
        #endregion


        #region 查找并真删除操作并立即保存（抛异常） + EntityEntry<TEntity> FindToDeleteSaveChanges(object id, Exception notFoundException)
        /// <summary>
        /// 查找并真删除操作并立即保存（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="notFoundException">未找到异常</param>
        /// <returns><see cref="EntityEntry{TEntity}"/></returns>
        EntityEntry<TEntity> FindToDeleteSaveChanges(object id, Exception notFoundException);
        #endregion

        #region 查找并真删除操作并立即保存（抛异常） + Task<EntityEntry<TEntity>> FindToDeleteSaveChangesAsync(object id, Exception notFoundException)
        /// <summary>
        /// 查找并真删除操作并立即保存（抛异常）
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="notFoundException">未找到异常</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FindToDeleteSaveChangesAsync(object id, Exception notFoundException);
        #endregion
    }
}