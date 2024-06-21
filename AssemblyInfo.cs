using NUnit.Framework;

// To define [Test] attributes
[assembly: Parallelizable(ParallelScope.Children)]
// Number of browsers
[assembly: LevelOfParallelism(4)]
