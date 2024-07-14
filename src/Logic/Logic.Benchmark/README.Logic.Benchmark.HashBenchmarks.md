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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,322.2 ns** |    **366.71 ns** |    **20.10 ns** |     **1,308.3 ns** |     **1,345.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,470.7 ns |     38.93 ns |     2.13 ns |     1,468.7 ns |     1,472.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,709.8 ns |     34.32 ns |     1.88 ns |     1,707.6 ns |     1,711.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,684.6 ns |     62.97 ns |     3.45 ns |     2,681.6 ns |     2,688.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       204.0 ns |     15.98 ns |     0.88 ns |       203.0 ns |       204.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.5 ns |     22.17 ns |     1.22 ns |       286.4 ns |       288.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       490.9 ns |     17.65 ns |     0.97 ns |       489.9 ns |       491.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,506.3 ns** |    **541.09 ns** |    **29.66 ns** | **1,545,472.0 ns** | **1,545,524.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,263.4 ns |  1,825.98 ns |   100.09 ns |   614,154.8 ns |   614,352.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,418.3 ns | 14,873.94 ns |   815.29 ns |   654,756.3 ns |   656,329.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,998.8 ns | 21,158.30 ns | 1,159.76 ns | 1,373,001.0 ns | 1,375,271.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,290.4 ns |  2,083.17 ns |   114.19 ns |   162,183.9 ns |   162,411.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,453.3 ns |    836.94 ns |    45.88 ns |    92,400.8 ns |    92,485.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,164.0 ns |  7,895.26 ns |   432.77 ns |    64,892.7 ns |    65,663.1 ns |      - |      40 B |
