import About from "./components/About";
import Contestants from "./components/Contestants";
import Home from "./components/Home/Home";
import Navbar from "./components/Navbar/Navbar";
//import Registration, { RegistrationLanding } from "./components/Registration/Registration";

import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./styling/components/Router.scss";
import "./App.scss";

function App() {
  return (
    <div id="App">
      <Router>
        <Navbar />
        <div id="page-wrap">
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/about" element={<About />} />
            <Route path="/players" element={<Contestants />} />
            {
              /*
              <Route path="/registration" element={<Registration />} />
              <Route path="/registration/landing" element={<RegistrationLanding />} />
              */
            }
          </Routes>
        </div>
      </Router>
    </div>
  );
}

export default App;
