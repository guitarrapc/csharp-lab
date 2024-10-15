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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,326.7 ns** |     **91.49 ns** |     **5.01 ns** |     **1,321.3 ns** |     **1,331.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,470.1 ns |    111.20 ns |     6.10 ns |     1,465.4 ns |     1,477.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,685.2 ns |     54.34 ns |     2.98 ns |     1,683.3 ns |     1,688.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,634.7 ns |     70.24 ns |     3.85 ns |     2,630.3 ns |     2,637.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.7 ns |     29.65 ns |     1.62 ns |       201.6 ns |       204.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       323.9 ns |      9.61 ns |     0.53 ns |       323.5 ns |       324.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       494.9 ns |     13.53 ns |     0.74 ns |       494.1 ns |       495.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,881.4 ns** |  **7,591.68 ns** |   **416.13 ns** | **1,545,631.7 ns** | **1,546,361.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,363.0 ns |  2,565.52 ns |   140.62 ns |   614,201.5 ns |   614,458.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,806.1 ns | 22,589.22 ns | 1,238.19 ns |   654,888.4 ns |   657,214.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,055.6 ns | 42,856.43 ns | 2,349.11 ns | 1,371,759.5 ns | 1,376,454.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,228.8 ns |    943.83 ns |    51.73 ns |   162,178.4 ns |   162,281.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,676.6 ns |  6,601.25 ns |   361.84 ns |    91,440.5 ns |    92,093.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,570.2 ns |  7,644.04 ns |   419.00 ns |    65,261.9 ns |    66,047.3 ns |      - |      40 B |
