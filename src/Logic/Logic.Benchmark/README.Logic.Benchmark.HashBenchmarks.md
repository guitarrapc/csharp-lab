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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,228.0 ns** |     **181.10 ns** |     **9.93 ns** |     **1,217.8 ns** |     **1,237.6 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,413.2 ns |      83.68 ns |     4.59 ns |     1,409.2 ns |     1,418.2 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,637.0 ns |      90.10 ns |     4.94 ns |     1,633.6 ns |     1,642.7 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,560.1 ns |     218.96 ns |    12.00 ns |     2,549.5 ns |     2,573.1 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       175.7 ns |      19.23 ns |     1.05 ns |       174.8 ns |       176.9 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       254.5 ns |      90.20 ns |     4.94 ns |       251.2 ns |       260.2 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       493.0 ns |      51.42 ns |     2.82 ns |       490.1 ns |       495.7 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,269.9 ns** |   **2,441.50 ns** |   **133.83 ns** | **1,553,135.1 ns** | **1,553,402.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,331.5 ns |   1,815.88 ns |    99.53 ns |   617,257.0 ns |   617,444.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,297.5 ns |  25,445.53 ns | 1,394.76 ns |   658,349.8 ns |   660,899.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,377,133.6 ns | 146,809.31 ns | 8,047.11 ns | 1,371,845.0 ns | 1,386,394.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,274.9 ns |   6,971.44 ns |   382.13 ns |   162,992.8 ns |   163,709.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,057.0 ns |   3,289.83 ns |   180.33 ns |    91,940.4 ns |    92,264.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,207.2 ns |   5,083.53 ns |   278.65 ns |    33,023.7 ns |    33,527.9 ns |      - |      40 B |
