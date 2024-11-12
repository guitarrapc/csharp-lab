```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,320.9 ns** |     **27.85 ns** |     **1.53 ns** |     **1,319.4 ns** |     **1,322.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,449.0 ns |     80.99 ns |     4.44 ns |     1,444.9 ns |     1,453.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,703.3 ns |    196.96 ns |    10.80 ns |     1,696.8 ns |     1,715.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,626.3 ns |     98.19 ns |     5.38 ns |     2,620.6 ns |     2,631.3 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.2 ns |      6.81 ns |     0.37 ns |       199.9 ns |       200.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       292.2 ns |     61.43 ns |     3.37 ns |       289.5 ns |       296.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       501.5 ns |      4.03 ns |     0.22 ns |       501.3 ns |       501.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,690.4 ns** |  **1,970.63 ns** |   **108.02 ns** | **1,545,565.8 ns** | **1,545,756.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   613,889.7 ns |  2,756.98 ns |   151.12 ns |   613,796.4 ns |   614,064.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,069.4 ns | 22,132.92 ns | 1,213.18 ns |   654,887.6 ns |   657,311.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,443.8 ns |  4,802.17 ns |   263.22 ns | 1,372,152.3 ns | 1,372,664.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,227.4 ns |    849.73 ns |    46.58 ns |   162,185.7 ns |   162,277.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,479.3 ns |  2,880.71 ns |   157.90 ns |    91,346.5 ns |    91,653.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,435.2 ns |  1,671.76 ns |    91.63 ns |    65,344.4 ns |    65,527.7 ns |      - |      40 B |
