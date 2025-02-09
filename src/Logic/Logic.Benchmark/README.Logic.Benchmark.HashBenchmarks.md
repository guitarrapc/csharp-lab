```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,223.2 ns** |      **42.87 ns** |     **2.35 ns** |     **1,221.8 ns** |     **1,225.9 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,424.1 ns |      90.30 ns |     4.95 ns |     1,418.9 ns |     1,428.8 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,656.8 ns |     281.80 ns |    15.45 ns |     1,646.0 ns |     1,674.5 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,626.8 ns |     316.99 ns |    17.38 ns |     2,612.7 ns |     2,646.2 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       178.7 ns |      27.27 ns |     1.49 ns |       177.4 ns |       180.4 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       259.4 ns |      44.01 ns |     2.41 ns |       256.7 ns |       261.3 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       471.6 ns |       1.97 ns |     0.11 ns |       471.5 ns |       471.7 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,349.9 ns** |   **4,122.40 ns** |   **225.96 ns** | **1,554,089.2 ns** | **1,554,488.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,540.9 ns |   2,970.07 ns |   162.80 ns |   617,365.9 ns |   617,687.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,388.3 ns |  18,054.24 ns |   989.61 ns |   658,368.7 ns |   660,344.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,384,458.4 ns | 132,599.74 ns | 7,268.24 ns | 1,380,218.7 ns | 1,392,850.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,284.5 ns |   2,064.89 ns |   113.18 ns |   163,171.3 ns |   163,397.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,929.9 ns |     522.09 ns |    28.62 ns |    91,896.8 ns |    91,947.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,172.3 ns |   6,602.74 ns |   361.92 ns |    32,834.7 ns |    33,554.4 ns |      - |      40 B |
