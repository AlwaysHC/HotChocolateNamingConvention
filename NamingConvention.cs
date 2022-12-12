//using System;
//using System.Reflection;
//using HotChocolate;
//using HotChocolate.Types;
//using HotChocolate.Types.Descriptors;

//namespace HotChocolateNamingConvention;

//public class NamingConventions: DefaultNamingConventions {
//    public override NameString GetMemberName(MemberInfo member, MemberKind kind) {
//        NameString B = base.GetMemberName(member, kind);
//        if (member.DeclaringType != null
//            && (member.DeclaringType == typeof(Query)
//                || member.DeclaringType == typeof(Mutation)
//                || member.DeclaringType == typeof(Subscription)
//                || member.DeclaringType.Name.EndsWith("Query")
//                || member.DeclaringType.Name.EndsWith("Mutation")
//                || member.DeclaringType.Name.EndsWith("Subscription"))) {
//            return B;
//        }
//        else {
//            return new(string.Concat(B.Value[..1].ToUpper(), B.Value.AsSpan(1)));
//        }
//    }

//    public override NameString GetArgumentName(ParameterInfo parameter)
//         => parameter.Name == null ? base.GetArgumentName(parameter) : new(string.Concat(parameter.Name[..1].ToUpper(), parameter.Name.AsSpan(1)));
//}
