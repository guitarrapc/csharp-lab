```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,300.1 ns** |     **36.91 ns** |     **2.02 ns** |     **1,298.3 ns** |     **1,302.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,445.6 ns |     71.32 ns |     3.91 ns |     1,441.1 ns |     1,448.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,679.9 ns |     79.22 ns |     4.34 ns |     1,675.6 ns |     1,684.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,624.8 ns |    134.84 ns |     7.39 ns |     2,617.1 ns |     2,631.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       191.7 ns |     21.21 ns |     1.16 ns |       190.7 ns |       193.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       269.3 ns |     16.60 ns |     0.91 ns |       268.2 ns |       269.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       491.1 ns |     70.83 ns |     3.88 ns |       488.8 ns |       495.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,812.0 ns** |  **7,459.59 ns** |   **408.89 ns** | **1,545,492.4 ns** | **1,546,272.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,132.3 ns |  2,242.45 ns |   122.92 ns |   614,032.3 ns |   614,269.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,648.6 ns | 16,049.57 ns |   879.73 ns |   654,876.3 ns |   656,606.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,866.0 ns | 22,584.32 ns | 1,237.92 ns | 1,372,437.8 ns | 1,374,631.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,175.2 ns |    297.37 ns |    16.30 ns |   162,164.5 ns |   162,193.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,706.9 ns |  8,572.04 ns |   469.86 ns |    91,360.6 ns |    92,241.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,729.9 ns |  7,026.56 ns |   385.15 ns |    33,492.4 ns |    34,174.2 ns |      - |      40 B |
