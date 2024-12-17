```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,338.5 ns** |      **80.43 ns** |     **4.41 ns** |     **1,333.5 ns** |     **1,341.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,447.1 ns |      94.09 ns |     5.16 ns |     1,441.2 ns |     1,450.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,675.4 ns |      77.51 ns |     4.25 ns |     1,671.3 ns |     1,679.8 ns | 0.0191 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,674.0 ns |   1,564.83 ns |    85.77 ns |     2,618.5 ns |     2,772.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.3 ns |     152.44 ns |     8.36 ns |       194.5 ns |       209.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       274.1 ns |      36.36 ns |     1.99 ns |       272.0 ns |       275.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       510.2 ns |      69.33 ns |     3.80 ns |       505.9 ns |       513.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,517.7 ns** |   **7,610.08 ns** |   **417.13 ns** | **1,545,197.0 ns** | **1,545,989.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   618,839.9 ns | 148,892.45 ns | 8,161.30 ns |   614,094.5 ns |   628,263.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,493.7 ns |  20,509.92 ns | 1,124.22 ns |   655,347.0 ns |   657,594.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,377,247.5 ns |  84,244.58 ns | 4,617.73 ns | 1,373,022.8 ns | 1,382,177.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,350.8 ns |   4,275.72 ns |   234.37 ns |   162,185.7 ns |   162,619.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    94,821.2 ns | 105,952.55 ns | 5,807.62 ns |    91,467.2 ns |   101,527.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,003.9 ns |   6,417.83 ns |   351.78 ns |    32,655.9 ns |    33,359.4 ns |      - |      40 B |
