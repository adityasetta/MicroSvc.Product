﻿namespace MicroSvc.Product.Infrastructure.Repositories
{
    using MicroSvc.Product.Domain.Repositories;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// The disposed flag.
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
        /// </summary>
        /// <param name="productContext">The product context.</param>
        public BaseRepository(ProductContext productContext)
        {
            this.ProductContext = productContext;
        }

        /// <summary>
        /// Gets the product context.
        /// </summary>
        /// <value>
        /// The product context.
        /// </value>
        protected ProductContext ProductContext { get; }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Protected implementation of Dispose pattern.
        /// </summary>
        /// <param name="disposing">True if any managed resourced needs to be disposed, false otherwise.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.ProductContext?.Dispose();
                this.disposed = true;
            }
        }
    }
}
