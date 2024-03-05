```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,312.7 ns** |      **28.05 ns** |      **1.54 ns** |     **1,311.4 ns** |     **1,314.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,453.9 ns |     292.22 ns |     16.02 ns |     1,443.2 ns |     1,472.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,689.8 ns |     106.36 ns |      5.83 ns |     1,683.3 ns |     1,694.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,652.3 ns |      42.43 ns |      2.33 ns |     2,649.7 ns |     2,654.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.2 ns |      10.60 ns |      0.58 ns |       199.6 ns |       200.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       333.7 ns |     595.20 ns |     32.63 ns |       314.7 ns |       371.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       497.9 ns |       7.29 ns |      0.40 ns |       497.5 ns |       498.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,594.3 ns** |  **13,798.25 ns** |    **756.33 ns** | **1,545,151.8 ns** | **1,546,467.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,775.2 ns |  19,405.33 ns |  1,063.67 ns |   614,057.3 ns |   615,997.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,004.6 ns |  10,551.93 ns |    578.39 ns |   654,632.8 ns |   655,671.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,382,186.5 ns | 262,588.27 ns | 14,393.35 ns | 1,373,452.5 ns | 1,398,799.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,361.2 ns |   2,510.77 ns |    137.62 ns |   162,270.8 ns |   162,519.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,095.5 ns |   6,400.35 ns |    350.82 ns |    91,691.1 ns |    92,317.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,024.0 ns |   1,044.99 ns |     57.28 ns |    64,979.6 ns |    65,088.6 ns |      - |      40 B |
