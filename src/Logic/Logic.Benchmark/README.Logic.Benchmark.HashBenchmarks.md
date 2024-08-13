```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,321.7 ns** |     **117.73 ns** |     **6.45 ns** |     **1,314.3 ns** |     **1,326.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,490.7 ns |     143.99 ns |     7.89 ns |     1,482.5 ns |     1,498.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,718.7 ns |      50.10 ns |     2.75 ns |     1,716.6 ns |     1,721.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,651.9 ns |     170.77 ns |     9.36 ns |     2,641.7 ns |     2,660.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       223.9 ns |      31.04 ns |     1.70 ns |       221.9 ns |       225.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       283.2 ns |      13.52 ns |     0.74 ns |       282.5 ns |       284.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       494.2 ns |      13.97 ns |     0.77 ns |       493.7 ns |       495.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,571.9 ns** |     **211.90 ns** |    **11.62 ns** | **1,545,564.3 ns** | **1,545,585.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,946.3 ns |  21,313.70 ns | 1,168.28 ns |   614,254.3 ns |   616,295.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,427.1 ns |   9,921.92 ns |   543.85 ns |   655,963.6 ns |   657,025.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,692.4 ns |  19,895.97 ns | 1,090.57 ns | 1,372,555.8 ns | 1,374,730.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   165,790.8 ns | 110,336.02 ns | 6,047.89 ns |   162,232.4 ns |   172,773.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,513.2 ns |   3,092.81 ns |   169.53 ns |    91,397.7 ns |    91,707.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,767.3 ns |   8,086.88 ns |   443.27 ns |    65,281.5 ns |    66,149.9 ns |      - |      40 B |
