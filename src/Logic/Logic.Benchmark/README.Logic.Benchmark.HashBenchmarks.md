```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,326.9 ns** |     **38.64 ns** |     **2.12 ns** |     **1,325.1 ns** |     **1,329.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,462.2 ns |     69.42 ns |     3.81 ns |     1,458.9 ns |     1,466.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,685.6 ns |     51.07 ns |     2.80 ns |     1,682.8 ns |     1,688.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,681.8 ns |    101.73 ns |     5.58 ns |     2,675.7 ns |     2,686.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.0 ns |     13.85 ns |     0.76 ns |       201.2 ns |       202.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.3 ns |     39.77 ns |     2.18 ns |       284.4 ns |       288.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       478.5 ns |     26.72 ns |     1.46 ns |       477.2 ns |       480.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,474.9 ns** |  **3,974.96 ns** |   **217.88 ns** | **1,545,266.0 ns** | **1,545,700.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,171.0 ns |  1,672.92 ns |    91.70 ns |   614,074.8 ns |   614,257.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,368.1 ns |  1,414.50 ns |    77.53 ns |   655,298.2 ns |   655,451.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,827.7 ns | 37,869.07 ns | 2,075.73 ns | 1,372,645.0 ns | 1,376,776.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,291.1 ns |  2,388.15 ns |   130.90 ns |   162,154.6 ns |   162,415.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,768.2 ns |  6,708.30 ns |   367.70 ns |    91,440.1 ns |    92,165.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,341.3 ns |  2,341.53 ns |   128.35 ns |    65,258.7 ns |    65,489.2 ns |      - |      40 B |
