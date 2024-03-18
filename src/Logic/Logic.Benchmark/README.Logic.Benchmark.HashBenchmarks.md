```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,310.4 ns** |    **102.40 ns** |     **5.61 ns** |     **1,305.5 ns** |     **1,316.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,467.8 ns |    299.88 ns |    16.44 ns |     1,456.2 ns |     1,486.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,709.5 ns |     34.49 ns |     1.89 ns |     1,707.7 ns |     1,711.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,689.2 ns |    838.34 ns |    45.95 ns |     2,662.1 ns |     2,742.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.9 ns |     22.37 ns |     1.23 ns |       201.7 ns |       204.2 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       294.5 ns |    282.57 ns |    15.49 ns |       284.0 ns |       312.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       519.8 ns |     61.11 ns |     3.35 ns |       516.4 ns |       523.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,913.6 ns** |  **4,160.55 ns** |   **228.05 ns** | **1,545,732.8 ns** | **1,546,169.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,322.1 ns |    335.45 ns |    18.39 ns |   614,301.9 ns |   614,337.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,772.4 ns | 16,751.24 ns |   918.19 ns |   655,066.4 ns |   656,810.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,197.9 ns | 45,032.14 ns | 2,468.36 ns | 1,373,161.4 ns | 1,377,943.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,400.5 ns |  4,761.87 ns |   261.01 ns |   162,226.7 ns |   162,700.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,497.7 ns |  2,721.08 ns |   149.15 ns |    91,384.4 ns |    91,666.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,253.5 ns |  7,380.70 ns |   404.56 ns |    64,896.1 ns |    65,692.7 ns |      - |      40 B |
