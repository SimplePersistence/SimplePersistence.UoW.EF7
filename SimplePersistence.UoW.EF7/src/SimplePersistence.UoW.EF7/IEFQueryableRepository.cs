namespace SimplePersistence.UoW.EF7
{
    using System;
    using Microsoft.Data.Entity;

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity,TId}"/> 
    /// for the Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TKey">The entity id type</typeparam>
    [CLSCompliant(false)]
    public interface IEFQueryableRepository<TEntity, in TKey>
        : IQueryableRepository<TEntity, TKey>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity,TId01,TId02}"/> 
    /// for the Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TKey01">The entity id first type</typeparam>
    /// <typeparam name="TKey02">The entity id second type</typeparam>
    [CLSCompliant(false)]
    public interface IEFQueryableRepository<TEntity, in TKey01, in TKey02>
        : IQueryableRepository<TEntity, TKey01, TKey02>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity,TId01,TId02,TId03}"/> 
    /// for the Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TKey01">The entity id first type</typeparam>
    /// <typeparam name="TKey02">The entity id second type</typeparam>
    /// <typeparam name="TKey03">The entity id third type</typeparam>
    [CLSCompliant(false)]
    public interface IEFQueryableRepository<TEntity, in TKey01, in TKey02, in TKey03>
        : IQueryableRepository<TEntity, TKey01, TKey02, TKey03>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity,TId01,TId02,TId03,TId04}"/> 
    /// for the Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TKey01">The entity id first type</typeparam>
    /// <typeparam name="TKey02">The entity id second type</typeparam>
    /// <typeparam name="TKey03">The entity id third type</typeparam>
    /// <typeparam name="TKey04">The entity id fourth type</typeparam>
    [CLSCompliant(false)]
    public interface IEFQueryableRepository<TEntity, in TKey01, in TKey02, in TKey03, in TKey04>
        : IQueryableRepository<TEntity, TKey01, TKey02, TKey03, TKey04>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }

    /// <summary>
    /// Specialized interface of an <see cref="IQueryableRepository{TEntity}"/> 
    /// for the Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    [CLSCompliant(false)]
    public interface IEFQueryableRepository<TEntity> : IQueryableRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// The Entity Framework database context
        /// </summary>
        DbContext Context { get; }

        /// <summary>
        /// The <see cref="DbSet{TEntity}"/> of this repository entity
        /// </summary>
        DbSet<TEntity> Set { get; }
    }
}
