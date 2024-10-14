using Microsoft.VisualStudio.TestTools.UnitTesting;

// class-level parallel
[assembly: Parallelize(Scope = ExecutionScope.ClassLevel)]

// method-level parallel
//[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]

// no parallel
//[assembly: DoNotParallelize]