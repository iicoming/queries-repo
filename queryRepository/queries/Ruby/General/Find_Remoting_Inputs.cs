CxList RemotingClasses = All.InheritsFrom("MarshalByRefObject").FindByType(typeof(ClassDecl));
CxList RemotingMethods = All.FindByType(typeof(MethodDecl)).GetByClass(RemotingClasses);
CxList PublicRemotingMethods = RemotingMethods.FindByFieldAttributes(Modifiers.Public);

result = All.FindByFathers(All.FindByFathers(PublicRemotingMethods)).FindByType(typeof(ParamDecl));