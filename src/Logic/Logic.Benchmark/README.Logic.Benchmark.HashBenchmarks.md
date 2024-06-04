```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error       | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,317.8 ns** |    **71.94 ns** |   **3.94 ns** |     **1,314.1 ns** |     **1,322.0 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,486.2 ns |   274.08 ns |  15.02 ns |     1,475.6 ns |     1,503.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,710.0 ns |    97.86 ns |   5.36 ns |     1,705.2 ns |     1,715.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,685.7 ns |   109.66 ns |   6.01 ns |     2,681.0 ns |     2,692.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.6 ns |    31.99 ns |   1.75 ns |       201.2 ns |       204.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       283.6 ns |     7.15 ns |   0.39 ns |       283.1 ns |       283.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       479.3 ns |    54.62 ns |   2.99 ns |       476.5 ns |       482.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,100.5 ns** | **5,449.30 ns** | **298.69 ns** | **1,545,845.4 ns** | **1,546,429.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,448.5 ns | 1,738.83 ns |  95.31 ns |   614,344.6 ns |   614,531.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,338.8 ns | 3,594.81 ns | 197.04 ns |   655,209.0 ns |   655,565.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,477.7 ns | 8,674.80 ns | 475.50 ns | 1,372,027.6 ns | 1,372,975.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,414.2 ns | 4,605.81 ns | 252.46 ns |   162,255.9 ns |   162,705.3 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,568.8 ns | 3,515.37 ns | 192.69 ns |    91,384.0 ns |    91,768.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,264.0 ns | 4,907.51 ns | 269.00 ns |    64,956.2 ns |    65,454.2 ns |      - |      40 B |
