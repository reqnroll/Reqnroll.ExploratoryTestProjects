// class-level parallel
[assembly: NUnit.Framework.Parallelizable(NUnit.Framework.ParallelScope.Fixtures)]
[assembly: NUnit.Framework.LevelOfParallelism(4)]

// method-level parallel
//[assembly: NUnit.Framework.Parallelizable(NUnit.Framework.ParallelScope.Children)]
//[assembly: NUnit.Framework.LevelOfParallelism(4)]
