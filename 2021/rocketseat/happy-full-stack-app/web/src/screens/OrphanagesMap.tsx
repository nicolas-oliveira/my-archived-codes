import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { Map, TileLayer, Marker, Popup } from 'react-leaflet';

import mapMarkerImg from '../images/logo-marker.svg';
import { FiPlus, FiArrowRight } from 'react-icons/fi';

import mapIcon from '../utils/mapIcon';
import api from '../services/api';

import '../styles/pages/ophernages-map.css';

interface Orphanage {
  id: number;
  latitude: number;
  longitude: number;
  name: string;
};

function OrphanagesMap() {
  const [orphanages, setOrphanages] = useState<Orphanage[]>([]);

  useEffect(() => {
    api.get('orphanages').then(response => {
      setOrphanages(response.data);
    })
  }, []);

  return (
    <div id="page-map">
      <aside>
        <header>
          <img src={mapMarkerImg} alt="" />
          <h2>Choose an orphanage on the map</h2>
          <p>Many children are waiting for your visit :)</p>
        </header>

        <footer>
          <strong>Passos</strong>
          <span>Minas Gerais</span>
        </footer>
      </aside>

      <Map
        center={[-20.7159296,-46.6059264]}
        zoom={15}
        style={{ width: "100%", height: "100%"}}
      >
        <TileLayer url="https://a.tile.openstreetmap.org/{z}/{x}/{y}.png"/>
        {
          orphanages.map(orphanage => {
            return (
              <Marker
                icon={mapIcon}
                position={[ orphanage.latitude, orphanage.longitude ]}
                key={orphanage.id}
              >
                <Popup closeButton={false} minWidth={240} maxWidth={240} className="map-popup">
                  {`${orphanage.name}`}
                  <Link to={`/orphanages/${orphanage.id}`}>
                    <FiArrowRight size={20} color="#fff"/>
                  </Link>
                </Popup>
              </Marker>
            );
          })
        }
      </Map>

      <Link to="/orphanages/create" className="create-orphanage">
        <FiPlus size={32} color="#fff" />
      </Link>
    </div>
  );
}

export default OrphanagesMap;