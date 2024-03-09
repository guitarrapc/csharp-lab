```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,324.0 ns** |    **116.44 ns** |     **6.38 ns** |     **1,316.7 ns** |     **1,328.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,462.7 ns |     20.30 ns |     1.11 ns |     1,461.4 ns |     1,463.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,724.6 ns |     58.14 ns |     3.19 ns |     1,722.0 ns |     1,728.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,680.9 ns |     60.02 ns |     3.29 ns |     2,678.9 ns |     2,684.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       207.0 ns |     42.70 ns |     2.34 ns |       205.0 ns |       209.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.0 ns |      7.87 ns |     0.43 ns |       285.5 ns |       286.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       504.0 ns |      9.13 ns |     0.50 ns |       503.5 ns |       504.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,991.6 ns** | **22,078.75 ns** | **1,210.21 ns** | **1,545,158.4 ns** | **1,547,379.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,225.4 ns |  1,330.57 ns |    72.93 ns |   614,172.1 ns |   614,308.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   657,139.4 ns | 38,620.73 ns | 2,116.93 ns |   654,906.5 ns |   659,117.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,437.7 ns | 35,900.06 ns | 1,967.80 ns | 1,371,886.9 ns | 1,375,651.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,455.9 ns |  3,297.89 ns |   180.77 ns |   162,334.4 ns |   162,663.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,553.8 ns |  5,470.63 ns |   299.86 ns |    91,345.4 ns |    91,897.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,182.2 ns |  3,578.47 ns |   196.15 ns |    64,962.0 ns |    65,338.2 ns |      - |      40 B |
