using Microsoft.VisualStudio.TestTools.UnitTesting;

// class-level parallel
//[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.ClassLevel)]

// method-level parallel
[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.MethodLevel)]

// no parallel
//[assembly: DoNotParallelize]