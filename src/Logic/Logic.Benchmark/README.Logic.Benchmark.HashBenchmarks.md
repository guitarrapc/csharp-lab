```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,256.1 ns** |     **58.70 ns** |     **3.22 ns** |     **1,254.1 ns** |     **1,259.8 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,422.9 ns |    235.22 ns |    12.89 ns |     1,410.0 ns |     1,435.8 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,660.5 ns |    113.88 ns |     6.24 ns |     1,654.8 ns |     1,667.2 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,610.0 ns |    102.89 ns |     5.64 ns |     2,604.8 ns |     2,616.0 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       184.7 ns |     49.79 ns |     2.73 ns |       181.6 ns |       186.3 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       263.6 ns |     62.50 ns |     3.43 ns |       260.0 ns |       266.8 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       485.7 ns |    273.22 ns |    14.98 ns |       474.8 ns |       502.8 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,267.1 ns** |    **542.33 ns** |    **29.73 ns** | **1,554,238.5 ns** | **1,554,297.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,728.1 ns |  2,137.07 ns |   117.14 ns |   617,635.7 ns |   617,859.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,685.7 ns | 27,182.44 ns | 1,489.96 ns |   658,773.6 ns |   661,405.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,386,724.7 ns | 75,869.66 ns | 4,158.67 ns | 1,383,505.3 ns | 1,391,420.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,378.7 ns |  7,129.98 ns |   390.82 ns |   163,119.4 ns |   163,828.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,032.5 ns |  3,963.48 ns |   217.25 ns |    91,884.5 ns |    92,281.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,361.7 ns |  7,993.80 ns |   438.17 ns |    32,858.3 ns |    33,657.6 ns |      - |      40 B |
