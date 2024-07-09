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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,363.2 ns** |    **673.12 ns** |    **36.90 ns** |     **1,320.9 ns** |     **1,388.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,463.8 ns |     14.48 ns |     0.79 ns |     1,463.0 ns |     1,464.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,701.6 ns |      5.77 ns |     0.32 ns |     1,701.5 ns |     1,702.0 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,653.8 ns |     44.79 ns |     2.46 ns |     2,651.0 ns |     2,655.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.5 ns |      2.36 ns |     0.13 ns |       203.3 ns |       203.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.1 ns |      2.80 ns |     0.15 ns |       285.0 ns |       285.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       500.6 ns |     60.39 ns |     3.31 ns |       498.2 ns |       504.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,227.1 ns** |  **3,071.26 ns** |   **168.35 ns** | **1,546,040.7 ns** | **1,546,368.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,121.6 ns |  1,751.23 ns |    95.99 ns |   614,046.0 ns |   614,229.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,799.6 ns | 15,041.81 ns |   824.49 ns |   655,171.3 ns |   656,733.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,376,102.7 ns | 43,987.17 ns | 2,411.09 ns | 1,373,380.9 ns | 1,377,970.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,295.9 ns |    800.03 ns |    43.85 ns |   162,253.6 ns |   162,341.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,356.1 ns |    388.76 ns |    21.31 ns |    91,339.2 ns |    91,380.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,200.1 ns |  3,400.23 ns |   186.38 ns |    64,996.5 ns |    65,362.3 ns |      - |      40 B |
