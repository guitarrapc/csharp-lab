```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,316.0 ns** |    **350.03 ns** |    **19.19 ns** |     **1,303.5 ns** |     **1,338.1 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,462.9 ns |     38.08 ns |     2.09 ns |     1,460.9 ns |     1,465.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,704.3 ns |     35.95 ns |     1.97 ns |     1,702.9 ns |     1,706.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,674.7 ns |     92.97 ns |     5.10 ns |     2,670.2 ns |     2,680.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.2 ns |     14.78 ns |     0.81 ns |       202.3 ns |       203.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.8 ns |      2.98 ns |     0.16 ns |       287.6 ns |       288.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       524.9 ns |     28.30 ns |     1.55 ns |       523.9 ns |       526.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,559.8 ns** | **18,334.79 ns** | **1,004.99 ns** | **1,545,462.4 ns** | **1,547,435.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,454.6 ns |  3,490.18 ns |   191.31 ns |   614,314.1 ns |   614,672.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,035.7 ns |  2,139.94 ns |   117.30 ns |   654,917.6 ns |   655,152.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,580.0 ns | 74,672.76 ns | 4,093.07 ns | 1,371,947.0 ns | 1,379,295.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,290.1 ns |  2,793.58 ns |   153.13 ns |   162,178.4 ns |   162,464.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,509.6 ns |  1,831.82 ns |   100.41 ns |    91,396.7 ns |    91,589.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,968.9 ns |    668.02 ns |    36.62 ns |    64,941.8 ns |    65,010.6 ns |      - |      40 B |
