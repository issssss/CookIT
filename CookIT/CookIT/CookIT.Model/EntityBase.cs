using System;

namespace CookIT.Model
{
	public abstract class EntityBase<TId> : IEquatable<EntityBase<TId>>
	{
		protected EntityBase(TId id)
		{
			if (Equals(id, default(TId)))
			{
				throw new ArgumentException("The ID cannot be the default value.", "id");
			}
			Id = id;
		}

		public virtual TId Id { get; set; }

		public virtual bool Equals(EntityBase<TId> other)
		{
			if (other == null)
			{
				return false;
			}
			return Id.Equals(other.Id);
		}

		public override bool Equals(object obj)
		{
			var entity = obj as EntityBase<TId>;
			if (entity != null)
			{
				return Equals(entity);
			}
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
	}
}