```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,318.1 ns** |    **147.91 ns** |   **8.11 ns** |     **1,312.3 ns** |     **1,327.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,456.6 ns |     88.82 ns |   4.87 ns |     1,452.1 ns |     1,461.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,692.4 ns |     55.15 ns |   3.02 ns |     1,690.6 ns |     1,695.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,671.2 ns |     73.25 ns |   4.02 ns |     2,666.6 ns |     2,673.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.4 ns |     22.13 ns |   1.21 ns |       202.2 ns |       204.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       292.1 ns |    185.68 ns |  10.18 ns |       285.6 ns |       303.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       495.7 ns |     29.24 ns |   1.60 ns |       494.3 ns |       497.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,621.5 ns** |  **1,532.45 ns** |  **84.00 ns** | **1,545,525.2 ns** | **1,545,679.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,260.9 ns |  1,118.36 ns |  61.30 ns |   614,191.3 ns |   614,306.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,139.5 ns |  1,795.07 ns |  98.39 ns |   655,050.5 ns |   655,245.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,646.1 ns | 17,199.15 ns | 942.74 ns | 1,372,015.0 ns | 1,373,729.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,363.1 ns |  5,959.18 ns | 326.64 ns |   162,145.5 ns |   162,738.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,696.6 ns |  9,252.48 ns | 507.16 ns |    91,371.3 ns |    92,281.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,369.6 ns |  8,649.82 ns | 474.13 ns |    64,823.8 ns |    65,679.8 ns |      - |      40 B |
