```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,329.3 ns** |     **416.01 ns** |     **22.80 ns** |     **1,315.9 ns** |     **1,355.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,464.5 ns |     110.00 ns |      6.03 ns |     1,459.1 ns |     1,471.0 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,697.5 ns |     116.03 ns |      6.36 ns |     1,691.6 ns |     1,704.3 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,669.5 ns |      65.21 ns |      3.57 ns |     2,665.7 ns |     2,672.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.8 ns |       7.21 ns |      0.40 ns |       199.5 ns |       200.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       292.3 ns |      38.40 ns |      2.10 ns |       289.8 ns |       293.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       482.6 ns |      34.52 ns |      1.89 ns |       480.4 ns |       484.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,225.2 ns** |   **1,133.01 ns** |     **62.10 ns** | **1,546,154.4 ns** | **1,546,270.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,254.0 ns |   2,994.19 ns |    164.12 ns |   614,105.9 ns |   614,430.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,076.0 ns |  27,297.64 ns |  1,496.28 ns |   655,188.9 ns |   657,803.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,380,046.1 ns | 212,140.03 ns | 11,628.11 ns | 1,373,072.0 ns | 1,393,469.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,815.6 ns |  15,469.74 ns |    847.95 ns |   162,297.1 ns |   163,794.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,917.4 ns |   7,694.03 ns |    421.74 ns |    91,437.4 ns |    92,228.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,706.9 ns |   8,244.81 ns |    451.93 ns |    65,263.8 ns |    66,167.2 ns |      - |      40 B |
