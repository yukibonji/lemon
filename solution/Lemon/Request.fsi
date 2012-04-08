﻿namespace Lemon

open System
open System.IO
open System.Web
open System.Xml.Linq

module Request =

  val (|URL|_|) : HttpRequest -> string list option

  val (|GET|_|) : HttpRequest -> HttpRequest option

  val (|POST|_|) : HttpRequest -> (HttpRequest * Stream) option

  val (|PUT|_|) : HttpRequest -> (HttpRequest * Stream) option

  val (|DELETE|_|) : HttpRequest -> HttpRequest option
 
  val existHeader : string -> (string * string) list -> bool

  val readText : Stream -> string

  val readXml : Stream -> XElement