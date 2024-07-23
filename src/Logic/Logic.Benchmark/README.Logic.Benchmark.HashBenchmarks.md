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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,347.9 ns** |     **93.63 ns** |     **5.13 ns** |     **1,342.4 ns** |     **1,352.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,488.1 ns |    213.02 ns |    11.68 ns |     1,477.7 ns |     1,500.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,725.3 ns |     36.92 ns |     2.02 ns |     1,723.1 ns |     1,727.0 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,703.9 ns |    115.53 ns |     6.33 ns |     2,696.9 ns |     2,709.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       205.0 ns |     28.90 ns |     1.58 ns |       203.6 ns |       206.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.8 ns |     19.83 ns |     1.09 ns |       285.9 ns |       288.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       526.7 ns |     43.25 ns |     2.37 ns |       524.2 ns |       528.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,441.2 ns** | **13,849.21 ns** |   **759.12 ns** | **1,545,961.0 ns** | **1,547,316.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,614.6 ns |  3,423.07 ns |   187.63 ns |   614,398.1 ns |   614,730.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,842.8 ns | 27,036.19 ns | 1,481.94 ns |   654,953.4 ns |   657,553.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,873.7 ns | 17,171.51 ns |   941.23 ns | 1,372,176.7 ns | 1,373,944.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   164,264.2 ns |  6,038.83 ns |   331.01 ns |   164,068.8 ns |   164,646.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    94,526.2 ns | 13,039.34 ns |   714.73 ns |    93,740.6 ns |    95,138.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,044.3 ns |  4,051.27 ns |   222.06 ns |    64,900.3 ns |    65,300.0 ns |      - |      40 B |
