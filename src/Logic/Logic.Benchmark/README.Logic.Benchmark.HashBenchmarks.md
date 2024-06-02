```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,310.1 ns** |      **78.24 ns** |     **4.29 ns** |     **1,305.3 ns** |     **1,313.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,451.5 ns |      52.63 ns |     2.88 ns |     1,449.3 ns |     1,454.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,714.7 ns |     405.57 ns |    22.23 ns |     1,701.3 ns |     1,740.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,656.3 ns |      76.07 ns |     4.17 ns |     2,652.8 ns |     2,660.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.0 ns |      14.86 ns |     0.81 ns |       198.3 ns |       199.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.9 ns |      11.47 ns |     0.63 ns |       287.3 ns |       288.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       502.0 ns |      27.49 ns |     1.51 ns |       500.7 ns |       503.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,975.7 ns** |   **7,722.49 ns** |   **423.30 ns** | **1,545,674.0 ns** | **1,546,459.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,468.4 ns |   5,710.24 ns |   313.00 ns |   614,254.2 ns |   614,827.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,165.8 ns |  10,327.40 ns |   566.08 ns |   655,570.5 ns |   656,697.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,378,217.8 ns | 142,530.22 ns | 7,812.56 ns | 1,372,435.6 ns | 1,387,105.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,319.6 ns |   2,837.61 ns |   155.54 ns |   162,201.8 ns |   162,495.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,434.3 ns |   1,734.22 ns |    95.06 ns |    91,378.1 ns |    91,544.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,320.1 ns |   5,100.77 ns |   279.59 ns |    65,003.9 ns |    65,534.4 ns |      - |      40 B |
