```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,225.9 ns** |    **273.35 ns** |    **14.98 ns** |     **1,217.1 ns** |     **1,243.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,367.2 ns |    127.27 ns |     6.98 ns |     1,362.0 ns |     1,375.1 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,710.7 ns |     71.56 ns |     3.92 ns |     1,706.2 ns |     1,713.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,581.9 ns |    221.57 ns |    12.15 ns |     2,568.3 ns |     2,591.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.3 ns |     41.54 ns |     2.28 ns |       198.8 ns |       202.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       284.5 ns |     22.27 ns |     1.22 ns |       283.2 ns |       285.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       493.9 ns |     31.80 ns |     1.74 ns |       491.9 ns |       495.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,289.2 ns** |  **6,245.26 ns** |   **342.32 ns** | **1,553,997.3 ns** | **1,554,666.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   618,777.2 ns | 16,944.40 ns |   928.78 ns |   617,858.5 ns |   619,715.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,798.9 ns | 24,361.15 ns | 1,335.32 ns |   658,549.2 ns |   661,205.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,383,423.6 ns | 77,947.47 ns | 4,272.56 ns | 1,380,523.4 ns | 1,388,330.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,332.2 ns |  5,540.97 ns |   303.72 ns |   163,149.3 ns |   163,682.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,135.7 ns |  3,091.67 ns |   169.46 ns |    91,972.7 ns |    92,310.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,898.5 ns |  8,029.19 ns |   440.11 ns |    65,641.4 ns |    66,406.7 ns |      - |      40 B |
