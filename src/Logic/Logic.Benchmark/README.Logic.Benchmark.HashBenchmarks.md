```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,131.9 ns** |      **12.87 ns** |     **0.71 ns** |     **1,131.3 ns** |     **1,132.7 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,312.5 ns |      94.74 ns |     5.19 ns |     1,307.4 ns |     1,317.8 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,510.3 ns |     260.37 ns |    14.27 ns |     1,500.7 ns |     1,526.7 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,372.2 ns |     576.20 ns |    31.58 ns |     2,352.3 ns |     2,408.6 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       161.2 ns |      11.22 ns |     0.61 ns |       160.6 ns |       161.8 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       243.6 ns |      21.75 ns |     1.19 ns |       242.9 ns |       244.9 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       431.0 ns |      61.98 ns |     3.40 ns |       428.0 ns |       434.7 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,447,832.9 ns** |  **36,088.22 ns** | **1,978.12 ns** | **1,446,134.5 ns** | **1,450,004.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   579,534.0 ns |  74,794.94 ns | 4,099.76 ns |   575,963.6 ns |   584,011.3 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   638,607.9 ns | 102,149.54 ns | 5,599.16 ns |   632,194.0 ns |   642,519.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,321,926.1 ns |  64,240.66 ns | 3,521.25 ns | 1,318,939.3 ns | 1,325,808.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   158,987.3 ns |   5,292.24 ns |   290.09 ns |   158,735.8 ns |   159,304.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    89,260.4 ns |   9,204.78 ns |   504.55 ns |    88,942.9 ns |    89,842.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    32,571.9 ns |   8,216.73 ns |   450.39 ns |    32,105.8 ns |    33,004.7 ns |      - |      40 B |
