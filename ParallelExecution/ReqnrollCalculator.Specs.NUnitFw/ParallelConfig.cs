// class-level parallel
[assembly: NUnit.Framework.Parallelizable(NUnit.Framework.ParallelScope.Fixtures)]

// method-level parallel
//[assembly: NUnit.Framework.Parallelizable(NUnit.Framework.ParallelScope.Children)]
//[assembly: NUnit.Framework.FixtureLifeCycle(NUnit.Framework.LifeCycle.InstancePerTestCase)]