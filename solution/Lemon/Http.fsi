﻿namespace Lemon

open System
open System.IO
open System.Web
open System.Xml.Linq

module Http =
  type Response = HttpResponse -> HttpResponse

  type Server = HttpRequest -> HttpResponse -> HttpResponse

  val (|URL|_|) : HttpRequest -> string list option

  val (|GET|_|) : HttpRequest -> HttpRequest option

  val (|POST|_|) : HttpRequest -> (HttpRequest * Stream) option

  val existHeader : string -> (string * string) list -> bool

  val readText : Stream -> string

  val readXml : Stream -> XElement

  val response : string -> Response

  val xmlResponse : XElement -> Response

  val setStatusCode : int -> Response

  val setHeader : string -> string -> Response

