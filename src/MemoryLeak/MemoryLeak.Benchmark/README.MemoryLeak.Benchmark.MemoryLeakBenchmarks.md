```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **758.5 ns** |   **234.6 ns** |  **12.86 ns** |   **744.6 ns** |   **769.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   713.1 ns |   315.8 ns |  17.31 ns |   693.1 ns |   723.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   720.3 ns |   496.9 ns |  27.24 ns |   690.7 ns |   744.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   727.8 ns |   419.4 ns |  22.99 ns |   705.4 ns |   751.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   721.0 ns |   466.2 ns |  25.56 ns |   691.5 ns |   736.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,785.2 ns** | **3,288.1 ns** | **180.23 ns** | **7,638.4 ns** | **7,986.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,261.4 ns | 3,426.9 ns | 187.84 ns | 7,125.9 ns | 7,475.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,589.5 ns | 5,547.1 ns | 304.06 ns | 7,322.1 ns | 7,920.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,408.1 ns | 1,278.5 ns |  70.08 ns | 7,344.6 ns | 7,483.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,479.8 ns | 3,228.2 ns | 176.95 ns | 7,304.9 ns | 7,658.7 ns | 0.1221 | 0.1144 |  10.23 KB |
