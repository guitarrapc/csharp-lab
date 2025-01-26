```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error           | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|----------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,227.9 ns** |       **127.53 ns** |      **6.99 ns** |     **1,223.5 ns** |     **1,236.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,419.9 ns |       185.73 ns |     10.18 ns |     1,411.0 ns |     1,431.0 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,639.1 ns |       119.84 ns |      6.57 ns |     1,633.2 ns |     1,646.2 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,677.1 ns |       236.45 ns |     12.96 ns |     2,666.7 ns |     2,691.6 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       178.4 ns |        20.05 ns |      1.10 ns |       177.2 ns |       179.3 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       261.5 ns |        18.78 ns |      1.03 ns |       260.3 ns |       262.2 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       486.3 ns |       117.63 ns |      6.45 ns |       481.8 ns |       493.7 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,555,415.2 ns** |    **45,059.55 ns** |  **2,469.87 ns** | **1,553,805.4 ns** | **1,558,258.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,463.2 ns |       555.02 ns |     30.42 ns |   617,428.3 ns |   617,483.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   698,777.8 ns | 1,240,467.65 ns | 67,994.22 ns |   659,293.9 ns |   777,290.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,380,218.4 ns |    25,074.83 ns |  1,374.44 ns | 1,379,142.1 ns | 1,381,766.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,111.5 ns |     3,689.43 ns |    202.23 ns |   162,980.6 ns |   163,344.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,918.1 ns |     2,213.11 ns |    121.31 ns |    91,801.5 ns |    92,043.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    32,945.8 ns |     2,749.78 ns |    150.72 ns |    32,835.3 ns |    33,117.5 ns |      - |      40 B |
