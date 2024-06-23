```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,319.5 ns** |    **265.37 ns** |    **14.55 ns** |     **1,310.7 ns** |     **1,336.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,450.2 ns |     76.38 ns |     4.19 ns |     1,446.3 ns |     1,454.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,719.9 ns |    119.00 ns |     6.52 ns |     1,716.1 ns |     1,727.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,645.9 ns |    107.49 ns |     5.89 ns |     2,640.1 ns |     2,651.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.1 ns |     27.71 ns |     1.52 ns |       199.8 ns |       202.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       292.9 ns |      3.22 ns |     0.18 ns |       292.7 ns |       293.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       504.7 ns |     19.05 ns |     1.04 ns |       504.0 ns |       505.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,600.6 ns** | **23,018.36 ns** | **1,261.71 ns** | **1,545,337.8 ns** | **1,547,861.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,088.7 ns |  2,923.48 ns |   160.25 ns |   613,929.4 ns |   614,249.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,780.1 ns |  9,661.50 ns |   529.58 ns |   656,342.7 ns |   657,368.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,147.9 ns | 28,734.33 ns | 1,575.03 ns | 1,371,934.6 ns | 1,374,927.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,191.0 ns |    668.33 ns |    36.63 ns |   162,161.6 ns |   162,232.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,376.7 ns |    141.74 ns |     7.77 ns |    91,367.7 ns |    91,381.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,937.9 ns |  1,211.69 ns |    66.42 ns |    64,861.7 ns |    64,983.3 ns |      - |      40 B |
