using System.Collections.Generic;
using System.Reflection;

namespace NHibernate.Mapping.ByCode
{
	public interface IModelExplicitDeclarationsHolder
	{
		IEnumerable<System.Type> RootEntities { get; }
		IEnumerable<System.Type> Components { get; }
		IEnumerable<System.Type> TablePerClassEntities { get; }
		IEnumerable<System.Type> TablePerClassHierarchyEntities { get; }
		IEnumerable<System.Type> TablePerConcreteClassEntities { get; }

		IEnumerable<MemberInfo> OneToOneRelations { get; }
		IEnumerable<MemberInfo> ManyToOneRelations { get; }
		IEnumerable<MemberInfo> ManyToManyRelations { get; }
		IEnumerable<MemberInfo> OneToManyRelations { get; }
		IEnumerable<MemberInfo> Any { get; }

		IEnumerable<MemberInfo> Poids { get; }
		IEnumerable<MemberInfo> VersionProperties { get; }
		IEnumerable<MemberInfo> NaturalIds { get; }

		IEnumerable<MemberInfo> Sets { get; }
		IEnumerable<MemberInfo> Bags { get; }
		IEnumerable<MemberInfo> IdBags { get; }
		IEnumerable<MemberInfo> Lists { get; }
		IEnumerable<MemberInfo> Arrays { get; }
		IEnumerable<MemberInfo> Dictionaries { get; }
		IEnumerable<MemberInfo> Properties { get; }

		void AddAsRootEntity(System.Type type);
		void AddAsComponent(System.Type type);
		void AddAsTablePerClassEntity(System.Type type);
		void AddAsTablePerClassHierarchyEntity(System.Type type);
		void AddAsTablePerConcreteClassEntity(System.Type type);

		void AddAsOneToOneRelation(MemberInfo member);
		void AddAsManyToOneRelation(MemberInfo member);
		void AddAsManyToManyRelation(MemberInfo member);
		void AddAsOneToManyRelation(MemberInfo member);
		void AddAsAny(MemberInfo member);

		void AddAsPoid(MemberInfo member);
		void AddAsVersionProperty(MemberInfo member);
		void AddAsNaturalId(MemberInfo member);

		void AddAsSet(MemberInfo member);
		void AddAsBag(MemberInfo member);
		void AddAsIdBag(MemberInfo member);
		void AddAsList(MemberInfo member);
		void AddAsArray(MemberInfo member);
		void AddAsMap(MemberInfo member);
		void AddAsProperty(MemberInfo member);
	}
}