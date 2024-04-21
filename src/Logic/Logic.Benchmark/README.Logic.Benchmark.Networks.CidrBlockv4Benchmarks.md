```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.5621 ns** | **7.2436 ns** | **0.3970 ns** |  **65.4394 ns** |  **65.2409 ns** |  **66.0060 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0216 ns | 0.6824 ns | 0.0374 ns |   0.0000 ns |   0.0000 ns |   0.0648 ns |         - |
| TryParseCidrString | 1      |  74.0887 ns | 3.3869 ns | 0.1856 ns |  74.0305 ns |  73.9392 ns |  74.2965 ns |         - |
| TryParseCidrBytes  | 1      |   3.0333 ns | 0.0111 ns | 0.0006 ns |   3.0334 ns |   3.0327 ns |   3.0339 ns |         - |
| **NewFromCidrString**  | **3**      | **195.3448 ns** | **4.8289 ns** | **0.2647 ns** | **195.2184 ns** | **195.1671 ns** | **195.6490 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6034 ns | 0.0875 ns | 0.0048 ns |   0.6015 ns |   0.5998 ns |   0.6089 ns |         - |
| TryParseCidrString | 3      | 231.4669 ns | 8.5230 ns | 0.4672 ns | 231.6558 ns | 230.9348 ns | 231.8099 ns |         - |
| TryParseCidrBytes  | 3      |   9.1634 ns | 0.4039 ns | 0.0221 ns |   9.1553 ns |   9.1464 ns |   9.1884 ns |         - |
